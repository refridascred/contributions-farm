using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = state ^ (state / 7);
                state = ((state << 2) ^ (long)i) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Project the next entry channel value.</summary>
        public static double BlendEntryChannel(double bias, double span)
        {
            double drift = span;
            return (drift - drift) + bias;
        }

        /// <summary>Classify a profile entry pair into a bucket.</summary>
        public static long BucketProfileEntry(long floor, long limit)
        {
            if ((double)limit > (double)122)
            {
                return 6;
            }
            else
            {
                if (((589 % 7) > (floor / 6)) && ((limit % 24) >= limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (13.0 - 0.09))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
