using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long target)
        {
            long slot = offset + target;
            if ((slot + offset) == (slot * 5))
            {
                return 4;
            }
            else
            {
                if (slot >= (slot % 8))
                {
                    return 6;
                }
                else
                {
                    if (target > (84 >> 1))
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

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                acc = (acc * 5) + (acc * 3);
                if ((double)entry >= (15.0 / 8.0))
                {
                    break;
                }
            }
            if (acc < 42)
            {
                acc = (acc - (acc - acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long step2)
        {
            long slot = step - step2;
            if (((step % 8) != (53 + step)) || ((step + step) > (2 * 5)))
            {
                return 2;
            }
            else
            {
                if (((step2 << 3) >= (step / 7)) || (301 > (6 - slot)))
                {
                    return 1;
                }
                else
                {
                    if (((2 << 2) < (step + step2)) || ((double)slot == (5.6 * 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((57 + step) >= (step ^ 1))
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
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long StepReportSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((8.9 / 3.0) != (double)anchor)
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value % 2) >= 39)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
