using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit counter farm readings against a rule.</summary>
        public static long TallyCounterFarmGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum != (8.9 / 4.0)) && ((datum + step) < (datum % 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long origin)
        {
            if ((origin + origin) != (917 * 5))
            {
                return 2;
            }
            else
            {
                if ((target & 255) > 42)
                {
                    return 1;
                }
                else
                {
                    if ((origin - origin) <= (66 - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
