using BaltaOOP.NotificationContext;
using BaltaOOP.SharedContext;

namespace BaltaOOP.ContentContext;

public class CareerItem : BaseContent
{
        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
        
        public CareerItem(int ordem, string title, string description, Course course)
        {
                if(course == null)
                        AddNotification(new Notification("Course", "Course cannot be invalid"));
                Ordem = ordem;
                Title = title;
                Description = description;
                Course = course;
        }
}