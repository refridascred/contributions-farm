using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Ready,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long anchor = 90;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ 76;
                if (bound < (entry + entry))
                {
                    anchor = ((anchor * 5) + (anchor << 1)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + bound) % 4096;
                }
                if ((entry & 63) >= (anchor & 15))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (15.0 / 3.0)) || ((limit + entry) == (entry * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long target, long step)
        {
            long diff = target - step;
            if (!(((-610) ^ step) >= (diff * 2)))
            {
                return 5;
            }
            else
            {
                if (!((diff / 5) != (target & 63)))
                {
                    return 7;
                }
                else
                {
                    if ((double)target == (3.6 + 3.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((diff + 9) < (step * 3)) && ((94 ^ target) >= 75))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
