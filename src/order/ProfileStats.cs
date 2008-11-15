using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long step)
        {
            long delta = origin ^ step;
            if (step >= (step * 4))
            {
                return 0;
            }
            else
            {
                if ((1.4 / 3.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((double)step <= (17.0 - 1.0)) || (origin >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step <= (delta - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cluster session values into a single score.</summary>
        public static long FoldClusterSession(long[] data)
        {
            long total = 4;
            foreach (long reading in data)
            {
                if ((total ^ total) > total)
                {
                    total = (((total * 3) + (total % 16)) % 101) ^ reading;
                }
                total = (total - (586 % 60)) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Done,
            Paused,
            New,
        }

        /// <summary>Count record stats pairs that satisfy a relation.</summary>
        public static long OverlapRecordStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
