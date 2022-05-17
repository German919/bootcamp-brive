# Mallory Furniture

![Mallory Furniture Logo](mockups/mallory-furniture-logo.png)

## Description
Mallory Furniture is a local vintage furniture retailer with a constantly changing selection. Their showroom has limited floor space so they initially wanted to build an ecommerce website to show all their inventory, including items in the warehouse.

They have obtained mockups for the site's design, and they have recently built a back-end API that contains their current listings. They now need to implement the front-end functionality. As a forward-looking company, they are interested in building the front-end in React to keep their views orderly and easily modifiable.

## Objectives

#### Learning Objectives
After completing this assignment you should be able to:
- Build a front-end React application from zero using `create-react-app`.
- Declare and style components in React.
- Use React methods to
  - Fetch data from a remote API and pass it as props.
  - Apply event listeners and manage state in a single React component.
  - Manage state across multiple React components.
- Use the React Router to determine what view is rendered and to navigate URLs.
- Query for data from an API in your React application.

## Project Requirements Summary
> **Make a React application that handles routes, fetches data, and renders components for Mallory Furniture's Front End.**

The site map should be structured like this:

```
/
/about
/terms
/all-products
/product/{product-id}
/category/{category-type}
```

- Users should be able to navigate the site from the navigation bar at the top of each page.

- You will need to fetch data from the [Mallory Furniture API](https://mallory-furniture-admin.now.sh/docs).

- For the multi-listing components, there should be a way to  filter for items that are `onSale`.

- Shopping cart component
  - Component should appear/disappear
  - When a User clicks *Add To Cart* button for a single product

## Setup

```sh
# create project
create-react-app project--mallory-furniture
cd project--mallory-furniture

# download project-files
curl https://raw.githubusercontent.com/muktek/project--mallory-furniture/master/project-files.zip > project-files.zip

# unzip project-files into src/ folder
unzip project-files.zip -d ./src/
```


### Mockups

- [Landing Page](mockups/mallory-landing.png)
- [Multiple Listing Page](mockups/mallory-multilisting-all.png)
  - [Demo of on sale filter feature](mockups/mallory-onsale-filter.gif)
- [Single Product Page](mockups/mallory-single.png)
- [Category Page](mockups/mallory-multilisting-category.png)
- Shopping Cart Component
  - [Basic Style](mockups/mallory-cart-static.png)
  - [Feature: Open + Close](mockups/mallory-cart-demo-part1.gif)
  - [Feature: Add/Remove Items](mockups/mallory-cart-demo-part2.gif)
- [Terms + Conditions Page](mockups/mallory-terms.png)

### DB Admin Notes
Mallory API Documentation https://mallory-furniture-admin.now.sh/docs/


### Designer Notes

#### Color Pallete
![color palette](mockups/mallory-color-palette.png)

#### Typography
From: [Google Fonts](https://fonts.google.com/)
- Main Font: `Source Sans Pro`
- Title Font: `Playfair Display`


### Explorer Mode
- Highlight the current page in the Nav Menu


### Adventure Mode
- For the multi-listing components, a user should be able to filter for multiple parameters:
  - On Sale
  - Quality
  - Max Price
