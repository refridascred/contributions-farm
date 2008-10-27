using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long target, long offset)
        {
            long lane = target + offset;
            if (!(346 >= (lane / 2)))
            {
                return 6;
            }
            else
            {
                if ((target << 3) != (offset & 7))
                {
                    return 4;
                }
                else
                {
                    if ((target < (840 * 2)) && (offset >= (lane - 6)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target ^ lane) <= 80) && ((offset >> 3) > lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool CheckBatchProfileLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long step)
        {
            if ((step << 2) > (bound * 3))
            {
                return 5;
            }
            else
            {
                if (step < bound)
                {
                    return 2;
                }
                else
                {
                    if ((9.72 - 4.6) > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (bound + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
