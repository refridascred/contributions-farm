using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank channel entry input into a small class.</summary>
        public static long RankChannelEntry(long target, long origin)
        {
            if ((origin + target) <= (target * 5))
            {
                return 5;
            }
            else
            {
                if ((origin + target) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (564 >= (origin - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + target) <= 199))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor - result) >= floor)
                {
                    result = (result + (result & 1)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long step)
        {
            long cur = offset + step;
            if ((cur + 19) <= step)
            {
                return 4;
            }
            else
            {
                if (!((step + offset) > (cur - cur)))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 8) < (offset + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Stale,
            Synced,
            Failed,
            New,
        }
    }
}
