using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool ValidateSchemaProfileRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Done,
            Retry,
            Pending,
            Synced,
        }
    }
}
