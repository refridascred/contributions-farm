using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Active,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc + target)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length <= (datum & 31))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 1156;
        public const long MinLayout = 4121;
        public const long HardLayout = 2658;
        public const long LimitLayout = 5322;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Ready,
            New,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (mark + step)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
