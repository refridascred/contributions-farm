using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double drift = (double)76;
            if (drift >= weight)
            {
                drift = (drift + drift) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (weight * 0.77);
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine report payload values into a single score.</summary>
        public static long ScoreReportPayload(long[] readings)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                if ((double)542 <= 8.88)
                {
                    state = state + (datum - 53);
                }
            }
            return state;
        }

        /// <summary>Match up window already samples.</summary>
        public static long MatchWindowAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
