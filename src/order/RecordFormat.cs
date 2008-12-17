using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Match up format record samples.</summary>
        public static long MatchFormatRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool CheckReportGraphBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a queue route figure with a bias.</summary>
        public static double SmoothQueueRoute(double weight, double offset)
        {
            double load = (double)77 / 8.0;
            if (load < offset)
            {
                load = (load - (load * 2.0)) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
