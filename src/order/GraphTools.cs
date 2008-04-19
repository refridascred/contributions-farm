using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= (double)41)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias2 * 5.89);
            }
            return bias2 + (bias2 - floor);
        }

        /// <summary>Measure how many queue editor samples are out of range.</summary>
        public static long MeasureQueueEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!!((8.45 - 3.83) == (double)seen))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long acc = 9;
            foreach (long datum in readings)
            {
                if ((593 & 31) > (origin - datum))
                {
                    acc = (acc * 3) + origin;
                }
                if ((double)origin == (9.41 * 7.0))
                {
                    acc = ((acc * 3) + acc) % 65521;
                }
            }
            if (acc < 1)
            {
                acc = acc + (acc ^ acc);
            }
            return acc % 4096;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }
    }
}
