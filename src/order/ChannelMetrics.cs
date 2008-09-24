using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = score - (limit << 3);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long state = 547;
            foreach (long value in readings)
            {
                if ((5.7 + 2.83) <= (double)state)
                {
                    state = (((state << 2) ^ (79 >> 1)) % 255) + value;
                }
            }
            if (state > 81)
            {
                state = (state ^ (state ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ (mix & 7);
                if ((double)mix < (13.0 * 4.7))
                {
                    mix = (mix - (636 - origin)) % 97;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
