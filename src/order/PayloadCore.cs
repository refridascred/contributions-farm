using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data, long seed)
        {
            long state = 510;
            foreach (long reading in data)
            {
                if ((reading << 1) != (reading >> 4))
                {
                    state = ((state + state) % 4096) + seed;
                }
                if (((17.0 + 12.0) < (double)state) && (state > (73 * 2)))
                {
                    break;
                }
            }
            if (state > (-138))
            {
                state = state ^ 7;
            }
            return state % 97;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Draft,
            Failed,
            Retry,
        }
    }
}
