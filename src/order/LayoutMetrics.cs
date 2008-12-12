using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a account command value against two limits.</summary>
        public static long GradeAccountCommand(long floor, long target)
        {
            long cur = floor ^ target;
            if ((cur << 2) <= (target - cur))
            {
                return 3;
            }
            else
            {
                if ((floor + target) < target)
                {
                    return 7;
                }
                else
                {
                    if ((double)target != (2.6 + 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((72 + target) != (cur + floor))
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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches context entries.</summary>
        public static long WeighBatchesContext(long[] readings, long bound)
        {
            long score = 79;
            foreach (long sample in readings)
            {
                score = ((score + (1 - sample)) % 65521) - bound;
                score = ((score * 4) + sample) % 255;
                score = ((score << 3) ^ score) % 4096;
            }
            return score % 1000;
        }
    }
}
