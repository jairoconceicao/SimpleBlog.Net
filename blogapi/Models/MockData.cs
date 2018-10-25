using System;
using System.Collections.Generic;

namespace blogapi.Models 
{
  public struct MockData 
  {
    public static PostModel[] POSTS = 
    {
      new PostModel() 
      { 
        Id = 1, 
        Title = "Ut enim blandit volutpat maecenas volutpat blandit", 
        Summary = "Lorem mollis aliquam ut porttitor leo. Consectetur libero id faucibus nisl tincidunt eget nullam",
        Author = "Donec Orci Porta", 
        DatePublish = DateTime.Now, 
        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Sed viverra tellus in hac habitasse platea dictumst. Euismod in pellentesque massa placerat. Eget egestas purus viverra accumsan. Sagittis orci a scelerisque purus semper eget duis at. Maecenas sed enim ut sem viverra aliquet eget sit amet. Mattis pellentesque id nibh tortor. Odio morbi quis commodo odio. Convallis tellus id interdum velit laoreet id donec ultrices. Fermentum et sollicitudin ac orci phasellus egestas tellus. Integer malesuada nunc vel risus commodo viverra maecenas accumsan" 
      },
      
      new PostModel() 
      { 
        Id = 2, 
        Title = "Id nibh tortor id aliquet lectus proin", 
        Summary = "Aliquam malesuada bibendum arcu vitae elementum curabitur vitae. Lacus vestibulum sed arcu non", 
        Author = "Feugiat Egestas", 
        DatePublish = DateTime.Now, 
        Text = "Id nibh tortor id aliquet lectus proin. Arcu ac tortor dignissim convallis aenean et tortor at risus. Lectus magna fringilla urna porttitor rhoncus dolor. Tellus in metus vulputate eu scelerisque felis. Odio pellentesque diam volutpat commodo sed egestas egestas fringilla. Sapien et ligula ullamcorper malesuada proin libero nunc. In fermentum posuere urna nec tincidunt praesent semper feugiat. Risus ultricies tristique nulla aliquet enim tortor at auctor. Lobortis feugiat vivamus at augue eget arcu dictum varius. Tincidunt ornare massa eget egestas purus viverra accumsan in. Arcu cursus vitae congue mauris rhoncus aenean vel elit scelerisque. Sit amet volutpat consequat mauris nunc congue nisi vitae. Eget gravida cum sociis natoque penatibus et magnis dis parturient. Eget est lorem ipsum dolor. Accumsan sit amet nulla facilisi morbi. Enim lobortis scelerisque fermentum dui faucibus. Elit sed vulputate mi sit amet mauris." 
      },
      
      new PostModel() 
      { 
        Id = 3, 
        Title = "Libero nunc consequat interdum varius sit", 
        Summary = "Urna et pharetra pharetra massa massa ultricies. Ipsum dolor sit amet consectetur adipiscing elit ut aliquam", 
        Author = "Nibh Mauris Cursus", 
        DatePublish = DateTime.Now, 
        Text = "Libero nunc consequat interdum varius sit. Risus pretium quam vulputate dignissim. Ut sem nulla pharetra diam. Adipiscing elit duis tristique sollicitudin. Netus et malesuada fames ac. Donec et odio pellentesque diam volutpat. Et magnis dis parturient montes nascetur. Dis parturient montes nascetur ridiculus mus. Orci ac auctor augue mauris augue. Augue interdum velit euismod in. Libero enim sed faucibus turpis in eu mi bibendum neque. Ac auctor augue mauris augue neque gravida in fermentum et. Amet justo donec enim diam vulputate ut. Tellus at urna condimentum mattis pellentesque id nibh tortor. In metus vulputate eu scelerisque. Aliquet lectus proin nibh nisl condimentum id venenatis a. Vel quam elementum pulvinar etiam non quam lacus suspendisse faucibus. Tellus mauris a diam maecenas sed. Nulla at volutpat diam ut venenatis. Facilisi cras fermentum odio eu." 
      },
      
      new PostModel() 
      { 
        Id = 4, 
        Title = "Vitae purus faucibus ornare suspendisse sed nisi lacus", 
        Summary = "Eu mi bibendum neque egestas congue quisque. Faucibus ornare suspendisse sed nisi lacus", 
        Author = "Mollis Nunc", 
        DatePublish = DateTime.Now, 
        Text = "Vitae purus faucibus ornare suspendisse sed nisi lacus. Nam libero justo laoreet sit amet cursus. Urna neque viverra justo nec ultrices dui sapien eget mi. Aliquam ut porttitor leo a diam sollicitudin tempor id. At elementum eu facilisis sed odio morbi quis commodo. Sagittis vitae et leo duis. Enim diam vulputate ut pharetra sit amet. Netus et malesuada fames ac turpis egestas sed. Ut placerat orci nulla pellentesque dignissim enim sit amet venenatis. Magna fringilla urna porttitor rhoncus dolor purus non enim praesent. At in tellus integer feugiat scelerisque. Vel fringilla est ullamcorper eget nulla facilisi. Etiam dignissim diam quis enim lobortis. Faucibus et molestie ac feugiat sed. Nulla pharetra diam sit amet nisl suscipit adipiscing. Aliquam ultrices sagittis orci a scelerisque purus semper eget. Pretium quam vulputate dignissim suspendisse in est ante in." 
      },
      
      new PostModel() 
      { 
        Id = 5, 
        Title = "Nulla aliquet porttitor lacus luctus accumsan tortor", 
        Summary = "Amet volutpat consequat mauris nunc congue nisi vitae suscipit. Sed augue lacus viverra vitae. Mauris vitae ultricies leo integer malesuada nunc vel", 
        Author = "Amet Massa", 
        DatePublish = DateTime.Now, 
        Text = "Nulla aliquet porttitor lacus luctus accumsan tortor. At elementum eu facilisis sed odio morbi quis commodo. In nibh mauris cursus mattis molestie a iaculis at. Ultrices dui sapien eget mi proin sed. Auctor eu augue ut lectus arcu bibendum at varius vel. Nunc id cursus metus aliquam eleifend mi in. Amet consectetur adipiscing elit pellentesque. Leo vel fringilla est ullamcorper eget nulla facilisi etiam dignissim. Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque. Diam sit amet nisl suscipit. Egestas maecenas pharetra convallis posuere morbi leo urna molestie at. Lacus sed viverra tellus in hac habitasse platea dictumst. Leo a diam sollicitudin tempor id eu. Scelerisque varius morbi enim nunc faucibus a. Blandit turpis cursus in hac habitasse platea." 
      },
    };
    
  }
}