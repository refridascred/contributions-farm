using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((-646) < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values, long offset)
        {
            long total = 427;
            foreach (long datum in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total << 2) ^ 3) ^ (long)i;
                    total = (total ^ datum) % 97;
                }
                if ((offset + offset) >= offset)
                {
                    total = (total ^ (datum ^ offset)) % 1000;
                }
                else
                {
                    total = (total + (51 / 3)) % 4096;
                }
            }
            if (total < 17)
            {
                total = total ^ (total ^ total);
            }
            return total;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Queued,
            Idle,
        }
    }
}
