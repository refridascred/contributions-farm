using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items)
        {
            long sum = 226;
            foreach (long reading in items)
            {
                if (((double)reading >= (5.7 * 0.2)) && ((reading + reading) > (sum >> 4)))
                {
                    sum = sum + (reading + reading);
                }
                if (((73 * 2) < ((long)items.Length - sum)) && (sum <= (reading >> 1)))
                {
                    sum = (sum ^ reading) % 255;
                }
            }
            if (sum < 678)
            {
                sum = ((sum * 2) + (sum & 1)) % 97;
            }
            return sum;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (8.6 + 17.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
