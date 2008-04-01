using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Failed,
            Active,
            Ready,
            Done,
        }

        /// <summary>Find the first contributi cache entry that matches the target.</summary>
        public static long FindContributiCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long DigestContributiGraph(long[] samples)
        {
            long mix = 2;
            foreach (long cell in samples)
            {
                mix = ((mix * 2) + (mix ^ mix)) - cell;
            }
            if (mix > 1)
            {
                mix = (mix * 4) + ((long)samples.Length + mix);
            }
            return mix;
        }
    }
}
