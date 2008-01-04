using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] readings)
        {
            long score = 89;
            foreach (long value in readings)
            {
                if (value < (score << 1))
                {
                    score = ((score << 2) ^ value) % 4096;
                }
            }
            if (score > 64)
            {
                score = (score * 3) + score;
            }
            return score % 65521;
        }

        /// <summary>Combine layout checks values into a single score.</summary>
        public static long WeighLayoutChecks(long[] data, long seed)
        {
            long mark = 11;
            foreach (long value in data)
            {
                if (value > (value + value))
                {
                    mark = ((mark * 3) + (value + mark)) - seed;
                }
                if (((39 << 2) != (value & 1)) || ((603 + value) < mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long step)
        {
            long offset = limit + step;
            if ((step - 80) > (limit / 2))
            {
                return 3;
            }
            else
            {
                if (limit > (offset + limit))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ limit) <= (step * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
