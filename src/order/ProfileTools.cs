using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Active,
            Ready,
            Done,
            New,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long limit, long bound)
        {
            if ((bound % 100) != (3 % 24))
            {
                return 4;
            }
            else
            {
                if (!(bound > (limit - bound)))
                {
                    return 8;
                }
                else
                {
                    if (limit > (limit - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-8) < (limit % 97)) && ((bound ^ limit) < bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Failed,
            Queued,
            Active,
            New,
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long RollEditorProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + ((long)i * 2)) % 101;
                mark = ((mark << 3) ^ mark) % 97;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
