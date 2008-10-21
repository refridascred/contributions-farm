using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long target2)
        {
            if (target < (target & 31))
            {
                return 6;
            }
            else
            {
                if ((double)target2 == (13.0 * 16.0))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings)
        {
            long score = 89;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (score << 2);
                score = (score << 2) ^ (sample + (-9));
                if ((sample + score) >= (score ^ 56))
                {
                    break;
                }
            }
            if (score > (-10))
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 934;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result * 4) + ((long)i >> 4);
                }
                result = result - (9 ^ origin);
                if (((datum + result) >= origin) && ((double)result < 0.2))
                {
                    result = (result + (result + datum)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long seed)
        {
            if ((8.0 + 7.19) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (96 < seed)
                {
                    return 0;
                }
                else
                {
                    if (!(seed >= (target - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((19.0 * 7.8) == (double)target) && ((59 ^ target) > (target - seed)))
                        {
                            return 2;
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
}
