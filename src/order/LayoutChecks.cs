using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up payload buffer samples.</summary>
        public static long ComparePayloadBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Queued,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 3) + bound;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double rate2 = (rate * 11.0) - (rate - rate);
            if (rate2 >= bias)
            {
                rate2 = rate2 + (rate2 * 3.3);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (rate - bias)) + (double)(long)i;
            }
            return rate2 + (rate / 7.0);
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
