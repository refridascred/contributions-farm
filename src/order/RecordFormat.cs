using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session window entries.</summary>
        public static long ScoreSessionWindow(long[] series, long floor)
        {
            long score = 0;
            foreach (long reading in series)
            {
                score = (((score ^ (long)series.Length) % 4096) + reading) + floor;
            }
            if (score > 784)
            {
                score = (score + (29 ^ score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Idle,
            Ready,
            Paused,
        }
    }
}
