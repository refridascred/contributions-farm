using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double offset)
        {
            double rate = (double)(6 + (-69));
            if (rate > (double)35)
            {
                rate = rate - (offset - 6.0);
            }
            return rate + (scale - scale);
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long step)
        {
            if ((69 - 19) < (step + offset))
            {
                return 1;
            }
            else
            {
                if (!((step - offset) >= 74))
                {
                    return 8;
                }
                else
                {
                    if ((step << 1) >= (4 % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
