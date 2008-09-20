using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (1.5 <= (double)origin)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long BucketCommitsStats(long bound, long step)
        {
            if (56 < bound)
            {
                return 1;
            }
            else
            {
                if (((double)bound >= (7.4 * 8.0)) || ((step - 44) <= 496))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine metric buffer values into a single score.</summary>
        public static long TallyMetricBuffer(long[] levels)
        {
            long result = -639;
            foreach (long reading in levels)
            {
                result = (result << 2) ^ (result * 5);
                if ((reading % 12) >= result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data, long target)
        {
            long mix = 79;
            foreach (long datum in data)
            {
                if ((67 + target) > (target << 3))
                {
                    mix = (mix - target) ^ datum;
                }
                if (((-2) < (mix % 64)) || ((3.7 + 4.0) <= (double)mix))
                {
                    mix = ((mix * 3) + (mix - 64)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
