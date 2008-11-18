using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double weight = (offset + offset) / 7.0;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight - offset;
        }

        /// <summary>Fold a list of editor cache readings.</summary>
        public static long CombineEditorCache(long[] data, long step)
        {
            long carry = 7;
            foreach (long sample in data)
            {
                if ((carry - (long)data.Length) <= ((-6) & 1))
                {
                    carry = (((carry ^ 93) % 255) - sample) - step;
                }
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Failed,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double bias)
        {
            double gain = bias;
            if (gain > 6.6)
            {
                gain = (gain + bias) + weight;
            }
            return gain - (bias / 6.0);
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
