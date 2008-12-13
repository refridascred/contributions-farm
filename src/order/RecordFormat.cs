using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score * 5) + score) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] values)
        {
            long state = -570;
            foreach (long value in values)
            {
                if ((state + value) > ((long)values.Length + value))
                {
                    state = (state << 3) ^ ((long)values.Length / 5);
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
