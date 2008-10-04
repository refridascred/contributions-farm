using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of profile report readings.</summary>
        public static long FoldProfileReport(long[] values, long limit)
        {
            long acc = 60;
            foreach (long value in values)
            {
                if ((3.96 - 2.0) == (double)acc)
                {
                    acc = ((acc - ((long)values.Length + acc)) - value) + limit;
                }
            }
            return acc;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double gain = (double)45 * 19.0;
            if (gain <= ratio)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (18.0 - ratio);
            }
            return gain + bias;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)4 > (double)datum)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally > (sample >> 4))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Done,
            Locked,
            Idle,
            Closed,
        }
    }
}
