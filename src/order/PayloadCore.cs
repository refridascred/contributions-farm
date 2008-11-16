using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepInterval = "strict-edge";
        public const string MinRecord = "local-edge";
        public const string HardRecord = "strict-edge";
        public const long MaxFactor = 2023;
        public const long CacheRecord = 2121;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double load = 9.2;
            if (load < 1.66)
            {
                load = (load - (double)6) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (6.0 * 3.8);
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long target)
        {
            long step = offset - target;
            if ((offset / 2) == (385 / 5))
            {
                return 8;
            }
            else
            {
                if (step <= offset)
                {
                    return 3;
                }
                else
                {
                    if (step <= (target * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ step) > target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
