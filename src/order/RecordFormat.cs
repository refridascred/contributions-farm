using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile schema entries.</summary>
        public static long FoldProfileSchema(long[] values, long target)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result - result) > (long)values.Length)
                {
                    result = (result ^ ((-747) >> 1)) % 255;
                }
                result = result - (cell - cell);
            }
            if (result < (-52))
            {
                result = ((result << 3) ^ (target + result)) % 255;
            }
            return result;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Idle,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long target, long step)
        {
            if (target > step)
            {
                return 0;
            }
            else
            {
                if ((step & 1) == (step / 2))
                {
                    return 5;
                }
                else
                {
                    if ((step % 10) < target)
                    {
                        return 3;
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
