using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (13.0 < (double)limit)
            {
                return 1;
            }
            else
            {
                if (((-995) * 5) > (bound * 4))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 4) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit <= (9.88 * 1.6)) && ((limit % 7) > bound2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 9295;
        public const long MinChecks = 1340;
        public const long LimitFactor = 4368;
        public const long RetryInterval = 6111;
        public const long WindowChecks = 3943;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                if (!(((double)state != (double)step) && ((double)state >= (12.0 - 0.1))))
                {
                    state = (state - ((long)i / 3)) % 101;
                    state = (state << 3) ^ (step + 8);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long target)
        {
            if ((target >> 1) > (origin * 5))
            {
                return 8;
            }
            else
            {
                if ((origin + 952) <= (origin + origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias2 / 4.0)) + (double)(long)i;
            }
            return rate + (bias / 9.0);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
