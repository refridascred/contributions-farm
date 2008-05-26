using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank metrics channel input into a small class.</summary>
        public static long GradeMetricsChannel(long bound, long origin)
        {
            if ((origin <= (bound & 7)) || (bound <= (origin + bound)))
            {
                return 2;
            }
            else
            {
                if (0.3 >= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((bound - 658) < ((-42) + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (9.7 * 8.2))
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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Grade a contributi buffer value against two limits.</summary>
        public static long GradeContributiBuffer(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (((8 + delta) < (delta - origin)) && ((delta & 7) < (211 / 7)))
            {
                return 1;
            }
            else
            {
                if ((origin & 127) == (origin % 97))
                {
                    return 8;
                }
                else
                {
                    if ((origin - origin) > delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta + origin) < (origin + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long anchor = 304;
            foreach (long sample in data)
            {
                if (anchor > sample)
                {
                    anchor = (anchor - (sample + anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (sample * 5)) % 4096;
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
