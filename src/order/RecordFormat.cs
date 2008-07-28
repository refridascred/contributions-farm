using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count - count) >= entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long target)
        {
            long anchor = 45;
            foreach (long datum in items)
            {
                anchor = ((anchor * 5) + (target + 552)) % 4096;
                if (!((target ^ anchor) >= anchor))
                {
                    anchor = (anchor - (anchor ^ datum)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Paused,
            Locked,
            New,
            Idle,
        }
    }
}
