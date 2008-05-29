using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + floor) >= (48 % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= 19.0)
            {
                ratio = (ratio + (double)(-508)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (6.33 / 3.0)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
