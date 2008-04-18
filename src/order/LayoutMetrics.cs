using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long ScoreEditorMetrics(long[] data)
        {
            long acc = -715;
            foreach (long value in data)
            {
                acc = (acc - (29 / 2)) + value;
            }
            return acc % 97;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long target2)
        {
            if (((double)target2 != (4.7 * 1.14)) || ((0.1 + 6.86) > (double)target))
            {
                return 4;
            }
            else
            {
                if (((target2 >> 3) >= target2) || ((target2 - target) >= (56 % 7)))
                {
                    return 1;
                }
                else
                {
                    if ((target * 5) > (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + target) >= (target2 + target)) && ((target - target2) >= 506))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached-edge";
        public const long BatchProfile = 4972;
        public const double IdleFactor = 59.15;
        public const long MaxProfile = 3610;
    }
}
