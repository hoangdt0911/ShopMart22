using ShopMart22.Application.ViewModels.Blog;
using ShopMart22.Application.ViewModels.Common;
using ShopMart22.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Application.Interfaces
{
    public interface IBlogService
    {
        BlogViewModel Add(BlogViewModel blogVm);

        void Update(BlogViewModel blog);

        void Delete(int id);

        List<BlogViewModel> GetAll();

        PagedResult<BlogViewModel> GetAllPaging(string keyword, int pageSize, int page = 1);

        List<BlogViewModel> GetLastest(int top);

        List<BlogViewModel> GetHotProduct(int top);

        List<BlogViewModel> GetListPaging(int page, int pageSize, string sort, out int totalRow);

        List<BlogViewModel> Search(string keyword, int page, int pageSize, string sort, out int totalRow);

        List<BlogViewModel> GetList(string keyword);

        List<BlogViewModel> GetReatedBlogs(int id, int top);

        List<string> GetListByName(string name);

        BlogViewModel GetById(int id);

        void Save();

        List<TagViewModel> GetListTagById(int id);

        TagViewModel GetTag(string tagId);

        void IncreaseView(int id);

        List<BlogViewModel> GetListByTag(string tagId, int page, int pageSize, out int totalRow);

        List<TagViewModel> GetListTag(string searchText);
    }
}
