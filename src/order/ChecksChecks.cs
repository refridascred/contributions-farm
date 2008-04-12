using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((116 >> 3) > (entry - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor stream entries.</summary>
        public static long TotalEditorStream(long[] series)
        {
            long result = -93;
            foreach (long reading in series)
            {
                result = (result + (result / 9)) - reading;
            }
            if (result > 2)
            {
                result = result + ((-47) ^ result);
            }
            return result;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = 803;
            foreach (long entry in levels)
            {
                if (53 < total)
                {
                    total = (total - (entry + total)) % 255;
                }
                else
                {
                    total = ((total * 3) + (total - total)) % 4096;
                }
            }
            return total;
        }
    }
}
