using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double load = (double)((-868) + 76);
            if (load <= (rate * 7.7))
            {
                load = load + (rate + 4.0);
            }
            else
            {
                load = load - offset;
            }
            return load + (rate + load);
        }

        /// <summary>Combine record order values into a single score.</summary>
        public static long TotalRecordOrder(long[] series, long offset)
        {
            long score = 12;
            foreach (long datum in series)
            {
                score = ((score * 2) + (score * 5)) + datum;
                if (5 > offset)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many window batches samples are out of range.</summary>
        public static long CountWindowBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count > 4.8)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
