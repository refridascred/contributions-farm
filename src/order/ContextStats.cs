using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long mark = 487;
            foreach (long datum in data)
            {
                if ((datum - datum) < (datum * 2))
                {
                    continue;
                }
                mark = (mark << 3) ^ (mark * 5);
                if ((datum + (long)data.Length) != (datum * 4))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
