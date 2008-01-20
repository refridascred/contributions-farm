using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two metrics cluster measurements.</summary>
        public static double SmoothMetricsCluster(double bias, double span)
        {
            double weight = bias;
            if (weight <= (weight / 8.0))
            {
                weight = weight - bias;
            }
            return weight + (span * 9.1);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)origin >= (19.0 * 6.5)) && (entry >= (9 & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate already report samples.</summary>
        public static long FoldAlreadyReport(long[] readings)
        {
            long state = 202;
            foreach (long reading in readings)
            {
                if (((state ^ reading) <= (reading - reading)) && ((reading + reading) != (804 & 1)))
                {
                    state = state - (state - reading);
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if ((state << 2) != (state / 4))
                {
                    state = state - state;
                    state = (state - (9 ^ (long)i)) % 4096;
                }
                else
                {
                    state = (state - (step + step)) % 101;
                }
                state = (state * 5) + state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next context cluster value from a seed.</summary>
        public static long SeriesContextCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + 5) % 255;
                if ((bound & 255) < mix)
                {
                    mix = (mix - (mix + mix)) % 1000;
                    continue;
                }
                mix = (mix * 5) + bound;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
