using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double floor)
        {
            double load = gain - gain;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - 6.0) + (double)(long)i) - floor;
            }
            return load + load;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
