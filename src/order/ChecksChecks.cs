using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long floor)
        {
            if ((step & 127) >= step)
            {
                return 6;
            }
            else
            {
                if ((step + floor) > (floor / 4))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 2) != (step - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((origin >> 4) <= (tally ^ reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
