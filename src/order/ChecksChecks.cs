using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of session account readings.</summary>
        public static long CompareSessionAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long acc = 6;
            foreach (long entry in readings)
            {
                if (((offset ^ entry) <= (entry * 2)) && ((double)acc <= (double)offset))
                {
                    acc = (acc + (offset % 97)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
