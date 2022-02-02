using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Article.Data
{
    public class ArticleService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public ArticleService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Articles
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await _appDBContext.Articles.ToListAsync();
        }
        #endregion

        #region Insert Article
        public async Task<bool> InsertArticleAsync(Article article)
        {
            await _appDBContext.Articles.AddAsync(article);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Article by Id
        public async Task<Article> GetArticleAsync(int Id)
        {
            Article article = await _appDBContext.Articles.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return article;
        }
        #endregion

        #region Update Article
        public async Task<bool> UpdateArticleAsync(Article article)
        {
            _appDBContext.Articles.Update(article);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteArticle
        public async Task<bool> DeleteArticleAsync(Article article)
        {
            _appDBContext.Remove(article);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}