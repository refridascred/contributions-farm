using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the stream command series from a seed.</summary>
        public static long IterateStreamCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 5) + (step - (long)i);
                if (!(((double)sum < (2.56 + 3.3)) && (((long)i << 1) > sum)))
                {
                    sum = (sum - (step + step)) % 97;
                }
                if (!(step >= (step ^ step)))
                {
                    sum = ((sum << 2) ^ (long)i) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
