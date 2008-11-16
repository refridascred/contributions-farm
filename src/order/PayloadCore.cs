using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length << 3) > seed)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((bound + entry) <= 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
