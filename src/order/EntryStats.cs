using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long offset, long seed)
        {
            long step = offset ^ seed;
            if ((offset < (step - seed)) && ((seed & 15) < step))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset - offset) >= (step * 4)) || (seed < (step >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - (-9)) != (step - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two payload githubfarm measurements.</summary>
        public static double BlendPayloadGithubfarm(double gain, double floor)
        {
            double rate = gain;
            if (rate <= (double)747)
            {
                rate = rate - (floor / 8.0);
            }
            else
            {
                rate = rate + 9.43;
            }
            return rate - rate;
        }

        /// <summary>Blend two cluster session measurements.</summary>
        public static double AdjustClusterSession(double ratio, double bias)
        {
            double weight = 9.2;
            if (weight >= 5.7)
            {
                weight = ((weight - (double)562) - ratio) + bias;
            }
            return weight + 7.0;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
