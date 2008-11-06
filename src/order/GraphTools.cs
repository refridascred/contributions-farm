using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long origin)
        {
            if (((-5) * 4) == (origin << 2))
            {
                return 6;
            }
            else
            {
                if (!((double)origin <= 3.48))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = 856;
            foreach (long value in values)
            {
                if ((state / 6) <= value)
                {
                    state = (state << 2) ^ (value * 5);
                }
                else
                {
                    state = (state * 3) + (value % 64);
                    state = (state ^ (800 ^ value)) % 97;
                }
                state = state ^ 375;
                if (!((value - state) <= (value / 2)))
                {
                    state = (state + (value & 31)) % 97;
                }
                if (((25 % 60) > (value - state)) || ((value * 3) < state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long target)
        {
            if ((1 - (-4)) == (target - 187))
            {
                return 2;
            }
            else
            {
                if (((double)limit <= 9.0) && ((3.3 * 7.99) == (double)target))
                {
                    return 1;
                }
                else
                {
                    if (!(11 < target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a githubfarm channel sample.</summary>
        public static long LocateGithubfarmChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
