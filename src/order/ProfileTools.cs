using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long bound)
        {
            long span = origin - bound;
            if ((origin & 7) > (bound / 7))
            {
                return 6;
            }
            else
            {
                if ((13.0 * 3.0) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (1.65 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin * 4) > (bound - span)) && (bound > (-757)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((seen >> 5) < item) || ((double)item <= (double)43)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double weight2 = (double)(954 & 31);
            if (weight2 < bias)
            {
                weight2 = weight2 - (bias / 5.0);
            }
            else
            {
                weight2 = weight2 + (3.2 - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - 18.0;
        }

        /// <summary>Iterate the checks record series from a seed.</summary>
        public static long RollChecksRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (329 & 7);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
