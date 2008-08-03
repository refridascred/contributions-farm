using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long origin)
        {
            if ((double)920 < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin + bound) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((origin % 12) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples)
        {
            long result = 84;
            foreach (long entry in samples)
            {
                if (543 <= (result - entry))
                {
                    result = (result * 4) + (entry / 5);
                }
                if ((entry ^ entry) == (entry << 2))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 9320;
        public const string SoftDepth = "alpha";
        public const long DefaultTools = 7147;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((mix >> 1) <= ((long)i >> 2))
                {
                    mix = mix ^ (34 & 63);
                }
                mix = (mix << 2) ^ (step + (long)i);
                if (!((6.92 / 5.0) >= (20.0 * 15.0)))
                {
                    mix = (mix - step) % 1000;
                    mix = mix - (step - mix);
                }
                else
                {
                    mix = ((mix << 2) ^ step) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
