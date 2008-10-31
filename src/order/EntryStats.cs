using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            if (((double)bound > 7.8) && ((offset + offset) >= (bound % 2)))
            {
                return 6;
            }
            else
            {
                if ((double)offset == (6.8 - 3.0))
                {
                    return 3;
                }
                else
                {
                    if (((17.0 * 9.0) >= (6.75 + 0.91)) && ((bound * 5) != (bound + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long target)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if ((double)entry == (1.25 / 2.0))
                {
                    result = ((result ^ (entry + 968)) % 255) + target;
                }
            }
            return result;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long floor, long floor2)
        {
            if (426 > (floor2 - floor))
            {
                return 3;
            }
            else
            {
                if ((4.3 * 2.5) == (double)floor2)
                {
                    return 6;
                }
                else
                {
                    if (floor2 <= (floor % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor2 > (3.3 + 7.3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
