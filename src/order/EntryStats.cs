using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Synced,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Active,
            Synced,
            Done,
        }

        /// <summary>Check that every stream support entry stays within the limit.</summary>
        public static bool CheckStreamSupportBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every entry notes entry stays within the limit.</summary>
        public static bool ValidateEntryNotesBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i << 1) < (bound >> 2)) && ((8.0 / 2.0) <= (double)carry))
                {
                    carry = (carry - ((long)i + bound)) % 1000;
                }
                carry = (carry + (carry >> 5)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry + (carry - bound)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
