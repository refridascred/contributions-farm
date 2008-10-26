using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Locked,
            Active,
        }

        /// <summary>Compare every pair of commits already readings.</summary>
        public static long PairCommitsAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
