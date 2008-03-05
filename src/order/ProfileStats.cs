using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many route channel samples are out of range.</summary>
        public static long CountRouteChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length + datum) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((result + (long)i) < (seed & 15)) && ((double)seed > (9.24 + 19.0)))
                {
                    result = ((result << 2) ^ result) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long floor)
        {
            if ((454 - step) <= (step ^ step))
            {
                return 7;
            }
            else
            {
                if (((step % 64) < floor) && ((floor + 617) != (24 & 15)))
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 4) != (step + 98))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step < 6.97)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Failed,
            Done,
            Paused,
        }
    }
}
