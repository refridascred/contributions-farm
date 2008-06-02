using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((tally / 3) >= (seed + seed)) || ((value << 2) <= (seed + tally))) || !((double)seed > 8.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Find the first window farm entry that matches the target.</summary>
        public static long LocateWindowFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long total = 2;
            foreach (long cell in samples)
            {
                if ((total <= (total & 127)) || ((2.0 / 7.0) > (double)total))
                {
                    break;
                }
                for (int i = 0; i < 11; i++)
                {
                    total = ((total ^ total) + (long)i) - cell;
                    total = total ^ ((long)samples.Length + total);
                }
                total = (total ^ total) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((total * 3) <= (long)i)
                {
                    total = total + (origin / 4);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
