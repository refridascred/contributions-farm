using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a payload checks pair into a bucket.</summary>
        public static long BucketPayloadChecks(long seed, long target)
        {
            if (seed > target)
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (double)target)
                {
                    return 8;
                }
                else
                {
                    if (((target & 255) >= (seed & 127)) && (seed <= (seed & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target ^ target) < (seed - 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc + target)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long step)
        {
            if ((origin - origin) < (origin + 545))
            {
                return 5;
            }
            else
            {
                if (!((origin + 3) < 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 1156;
        public const long MinLayout = 4121;
        public const long HardLayout = 2658;
        public const long LimitLayout = 5322;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items, long offset)
        {
            long state = 26;
            foreach (long item in items)
            {
                if ((offset - state) >= (offset & 15))
                {
                    state = (state << 3) ^ (item / 6);
                }
            }
            return state;
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long TallySchemaMetricsMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)hits != (1.0 / 9.0)) || (1.55 < (double)hits))
                {
                    hits = ((hits + 1) - entry) - target;
                }
            }
            return hits;
        }
    }
}
