using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Closed,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long seed)
        {
            long lane = origin - seed;
            if ((lane > (lane << 2)) || (seed <= (seed - lane)))
            {
                return 7;
            }
            else
            {
                if (!((double)lane >= (7.4 * 7.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + lane) <= (lane + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ score) % 255;
                if (!(score <= floor))
                {
                    score = (score - (score + score)) % 1000;
                }
                if ((floor / 7) > (floor + floor))
                {
                    score = (score ^ 538) % 101;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
