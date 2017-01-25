using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineGame.Sample
{
    public class WaitForData : NativeActivity<Int32>
    {
        [RequiredArgument]
        public InArgument<string> BookmarkName { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            context.CreateBookmark(BookmarkName.Get(context), new BookmarkCallback(OnResumeBookmark));
        }

        protected override bool CanInduceIdle
        {
            get
            {
                return true;
            }
        }

        private void OnResumeBookmark(NativeActivityContext context, Bookmark bookmark, object value)
        {
            Result.Set(context, (Int32)value);
        }
    }
}
