using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = 697;
            foreach (long datum in values)
            {
                if ((mix ^ datum) <= (datum & 3))
                {
                    mix = mix + (mix - mix);
                }
                if ((mix / 8) <= mix)
                {
                    break;
                }
            }
            if (mix > 114)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Compare every pair of window counter readings.</summary>
        public static long CompareWindowCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Failed,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double weight2 = (floor / 5.0) + (double)8;
            if (weight2 <= (floor / 2.0))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (2.0 * 9.8)) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((3.42 + 7.1) != (double)step)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
