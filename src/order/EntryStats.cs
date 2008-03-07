using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 942;
            foreach (long value in levels)
            {
                anchor = ((anchor * 5) + value) + floor;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mix = 51;
            foreach (long item in items)
            {
                mix = mix + (mix << 2);
                if (((6 + item) <= mix) && ((13.0 + 8.9) != (double)mix))
                {
                    mix = (mix - ((long)items.Length & 255)) % 97;
                }
                if (((double)item <= (14.0 + 1.23)) || ((2.31 + 7.0) <= (double)mix))
                {
                    break;
                }
            }
            if (mix < 208)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
