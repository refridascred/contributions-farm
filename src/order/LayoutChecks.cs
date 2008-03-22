using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples, long bound)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                score = (score ^ ((-423) * 4)) % 4096;
                if (!((0.02 - 0.3) > (double)bound))
                {
                    score = ((score * 5) + cell) % 97;
                }
                if ((score * 4) != (bound & 63))
                {
                    break;
                }
            }
            if (score > 435)
            {
                score = score - (bound + score);
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Paused,
            New,
            Dropped,
            Queued,
        }
    }
}
