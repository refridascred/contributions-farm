using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit batch batches readings against a rule.</summary>
        public static long MeasureBatchBatchesOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (target >= (target + hits))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long step)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                result = ((result ^ (result + 4)) + datum) + step;
                result = (result ^ 25) % 255;
            }
            return result;
        }
    }
}
